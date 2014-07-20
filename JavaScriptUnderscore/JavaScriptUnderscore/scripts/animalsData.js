define(['animal'], function(Animal){
    var animalsData = [];

    animalsData.push(new Animal('dog', 4));
    animalsData.push(new Animal('butterfly', 6));
    animalsData.push(new Animal('caterpillar', 100));
    animalsData.push(new Animal('human', 2));
    animalsData.push(new Animal('octopus', 8));

    return animalsData;
})