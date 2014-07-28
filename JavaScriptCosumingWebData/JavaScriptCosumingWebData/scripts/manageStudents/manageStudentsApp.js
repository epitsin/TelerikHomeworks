(function () {
    'use strict';

    require.config({
        paths: {
            jquery: '../libs/jquery-2.1.1.min',
            q: '../libs/q',
            makeRequests: 'modules/makeRequests'
        }
    });

    require(['jquery', 'q', 'makeRequests'], function ($, Q, makeRequests) {

        var resourceUrl = 'http://localhost:3000/students';

        //Post a student when the post button is clicked
        $('#postStudent').on('click', function () {
            var $name = $('#studentName').val();
            var $grade = $('#studentGrade').val();
            var studentInfo = {
                name: $name,
                grade: $grade
            };

            makeRequests.postJSON(resourceUrl, studentInfo)
                .then(function (student) {
                    $("#http-response").html(student.name + ' posted successfully!');
                }, function (student) {
                    $("#http-response").html(student.name + ' was NOT posted successfully!');
                });

        });

        //Show all the students when the button get is clicked
        $('#showStudents').on('click', function () {
            makeRequests.getJSON(resourceUrl)
            .then(function (data) {
                if (data) {
                    var i, student, len, $studentsList;

                    $studentsList = $('<ul />');
                    for (i = 0, len = data.students.length; i < len; i += 1) {
                        student = data.students[i];
                        $('<li />')
                            .html('<strong>Name: </strong>' + student.name + ' <strong>Grade: </strong>' + student.grade + ' <strong>ID: </strong>' + student.id)
                            .appendTo($studentsList);
                    }

                    $("#http-response").html($studentsList);
                }

                console.log('Students loaded successfully!');
            }, function (err) {
                console.log(err);
            });
        });

        //Deletes the student with the given ID
        $('#deleteStudent').on('click', function () {
            var $id = $('#studentId').val();

            makeRequests.deleteJSON('http://localhost:3000/students/' + $id)
                .then(function () {
                    $("#http-response").html('Student deleted successfully!');
                }, function () {
                    $("#http-response").html('Student was not deleted!');
                });
        });
    });
}());