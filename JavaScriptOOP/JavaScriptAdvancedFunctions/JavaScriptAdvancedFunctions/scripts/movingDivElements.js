var movingShapes = (function () {
    function add(shape) {
        var currDiv = document.createElement('div');

        currDiv.innerHTML += '<strong>div</strong>';
        currDiv.style.textAlign = 'center';

        currDiv.style.width = getRandomNumber(20, 100) + 'px';
        currDiv.style.height = getRandomNumber(20, 100) + 'px';

        currDiv.style.backgroundColor = getRandomColor();
        currDiv.style.color = getRandomColor();

        currDiv.style.border = getRandomNumber(1, 20) + 'px' + ' solid ' + getRandomColor();
        currDiv.style.borderRadius = getRandomNumber(0, 100) + 'px';

        currDiv.style.position = 'absolute';

        var wrapper = document.getElementById('wrapper');
        wrapper.appendChild(currDiv);

        if (shape == 'ellipse') {
            var centerX = 200;
            var centerY = 200;
            var radius = 50;

            var angle = 0;

            var functionTimer = setInterval(function moveDivs() {
                angle++;
                if (angle === 360) {
                    angle = 0;
                }

                var left = centerX + Math.cos((2 * 3.14 / 180) * (angle)) * radius;
                var right = centerY + Math.sin((2 * 3.14 / 180) * (angle)) * radius;

                currDiv.style.left = left + 'px';
                currDiv.style.top = right + 'px';
            }, 30);
        }
        else {
            var centerX = 600;
            var centerY = 200;
            var direction = 0;

            var functionTimer = setInterval(function moveDivs() {
                if (direction > 3) {
                    direction = 0;
                }

                switch (direction) {
                    case 0: centerX += 5;
                        if (centerX > 700) {
                            direction++;
                        }
                        break;
                    case 1: centerY += 5;
                        if (centerY > 300) {
                            direction++;
                        }
                        break;
                    case 2: centerX -= 5;
                        if (centerX < 600) {
                            direction++;
                        }
                        break;
                    case 3: centerY -= 5;
                        if (centerY < 200) {
                            direction++;
                        }
                        break;
                }


                currDiv.style.left = centerX + 'px';
                currDiv.style.top = centerY + 'px';
            }, 50);
        }

    }

    function getRandomNumber(min, max) {
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }


    function getRandomColor() {
        var red = Math.floor(Math.random() * 256);
        var green = Math.floor(Math.random() * 256);
        var blue = Math.floor(Math.random() * 256);

        return 'rgb(' + red + ',' + green + ',' + blue + ')';
    }

    return {
        add: add
    };

})();
