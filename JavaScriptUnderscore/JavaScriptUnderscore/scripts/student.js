define(function () {
    'use strict';

    var Student;

    Student = (function () {
        function Student(firstName, secondName, age, marks) {
            this._firstName = firstName;
            this._secondName = secondName;
            this._age = age;
            this._marks = marks;
        }

        Student.prototype.firstName = function (params) {
            if (params) {
                this._firstName = params;
            }
            else {
                return this._firstName;
            }
        }

        Student.prototype.secondName = function (params) {
            if (params) {
                this._secondName = params;
            }
            else {
                return this._secondName;
            }
        }

        Student.prototype.age = function (params) {
            if (params) {
                this._age = params;
            }
            else {
                return this._age;
            }
        }

        Student.prototype.marks = function (params) {
            if (params) {
                this._marks = params;
            }
            else {
                return this._marks;
            }
        }

        return Student;
    }());

    return Student;
})