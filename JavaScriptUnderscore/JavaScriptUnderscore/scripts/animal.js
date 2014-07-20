define(function () {
    'use strict';

    var Animal;

    Animal = (function () {
        var LEGSNUM = [2, 4, 6, 8, 100];
        function validateNumOfLegs(num) {
            if (LEGSNUM.indexOf(num) >= 0) {
                return true;
            }

            return false;
        }

        function Animal(species, numOfLegs) {
            if (!validateNumOfLegs(numOfLegs)) {
                throw new Error('Invalid number of legs!');
            }

            this._species = species;
            this._numOfLegs = numOfLegs;
        }

        Animal.prototype.species = function (params) {
            if (params) {
                this._species = params;
            }
            else {
                return this._species;
            }
        }

        Animal.prototype.numOfLegs = function (params) {
            if (params) {
                if (!validateNumOfLegs(params)) {
                    throw new Error('Invalid number of legs!');
                }

                this._numOfLegs = params;
            }
            else {
                return this._numOfLegs;
            }
        }

        return Animal;
    }());

    return Animal;
})