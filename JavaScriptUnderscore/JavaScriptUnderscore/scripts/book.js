define(function () {
    'use strict';

    var Book;

    Book = (function () {
        function Book(name, author) {
            this._name = name;
            this._author = author;
        }

        Book.prototype.name = function (params) {
            if (params) {
                this._name = params;
            }
            else {
                return this._name;
            }
        }

        Book.prototype.author = function (params) {
            if (params) {
                this._author = params;
            }
            else {
                return this._author;
            }
        }

        return Book;
    }());

    return Book;
})