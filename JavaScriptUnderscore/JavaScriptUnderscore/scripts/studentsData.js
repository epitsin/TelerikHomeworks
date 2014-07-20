/// <reference path="student.js" />

define(['student'], function (Student) {
    'use strict';
    var studentsData = [];

    studentsData.push(new Student('Ivan', 'Todorov', 20, [3, 4, 5, 6]));
    studentsData.push(new Student('Peter', 'Ivanov', 2, [2, 2, 2, 2]));
    studentsData.push(new Student('Todor', 'Ivanov', 65, [3, 3, 3, 3]));
    studentsData.push(new Student('Penka', 'Georgieva', 34, [4, 4, 4, 4]));
    studentsData.push(new Student('Iliana', 'Dimitrova', 23, [5, 5, 5, 5]));
    studentsData.push(new Student('Ivan', 'Goshkov', 16, [6, 6, 6, 6]));

    return studentsData;
});