/// <reference path="libs/underscore-min.js" />
(function () {
    'use strict';

    require(['studentsData', 'animalsData', 'bookData', 'libs/underscore-min'], function (studentsData, animalsData, booksData) {

        //returns an array of 2 students - Ivan Todorov and Peter Petrov
        console.log('Filtered by first name < second name alphabetically:');
        console.log(_.filter(studentsData, function (a) {
            var textA, textB;
            textA = a.firstName().toUpperCase();
            textB = a.secondName().toUpperCase();
            return textA < textB;
        }));

        //returns an array of 2 students - Ivan Todorov and Iliana Dimitrova
        console.log('Filtered by students between 18 and 24:');
        console.log(_.filter(studentsData, function (a) {
            if (a.age() > 18 && a.age() < 24) {
                return a.firstName() + ' ' + a.secondName();
            }
        }));

        //returns one student - Pesho Goshkov
        console.log('The student with the highest mark:');
        console.log(_.max(studentsData, function (a) {
            var sumOfMarks = 0;

            for (var i = 0; i < a.marks().length; i++) {
                sumOfMarks += a.marks()[i];
            }

            return sumOfMarks;
        }));

        console.log('------------------------------------');

        //returns 5 groups with one animal in each group
        console.log('Animals grouped by species and sorted by legs:');
        console.log(_.groupBy(animalsData, function (a) {
            return a.species();
        }));

        //returns the total number of legs - 120
        console.log('Animals grouped by species and sorted by legs:');
        console.log(_.reduce(animalsData, function (a, b) {
            return a + b.numOfLegs();
        }, 0));

        //returns one object with the most popular author
        console.log('The book with the most popular author:');
        console.log(_.chain(booksData)
                        .countBy(function (a) {
                            return a.author();
                        })
                        .pairs()
                        .max(_.last)
                        .value());

        //returns one object with the most popular first name
        console.log('The student with the most popular first name:');
        console.log(_.chain(studentsData)
                        .countBy(function (a) {
                            return a.firstName();
                        })
                        .pairs()
                        .max(_.last)
                        .value());

        //returns one object with the most popular last name
        console.log('The student with the most popular last name:');
        console.log(_.chain(studentsData)
                        .countBy(function (a) {
                            return a.secondName();
                        })
                        .pairs()
                        .max(_.last)
                        .value());
    });
}());