var snakeGame = (function () {
    var canvas = $("#canvas")[0];
    var ctx = canvas.getContext("2d");
    var w = $("#canvas").width();
    var h = $("#canvas").height();
    var cw = 10;
    var d;
    var score;

    var Snake = (function () {
        var Snake = function (length) {
            this.length = length;
            this.snakeArray = [];
        };

        Snake.prototype.createInitialSnake = function () {
            for (var i = this.length - 1; i >= 0; i--) {
                //Create a horizontal snake starting from the top left
                this.snakeArray.push({ x: i, y: 0 });
            }
        }

        return Snake;
    }());

    var Food = (function () {
        var Food = function (width, height, cellWidth) {
            this.x = getRandomNumber(width, cellWidth),
            this.y = getRandomNumber(height, cellWidth)
        };

        //Create a cell with x/y between 0-44
        //Because there are 45(450/10) positions accross the rows and columns
        function getRandomNumber(firstNum, secondNum) {
            return Math.round(Math.random() * (firstNum - secondNum) / secondNum);
        }

        return Food;
    }());
    var food;
    function start() {
        d = "right"; //default direction

        var snake = new Snake(5);
        snake.createInitialSnake();

        makeFood();
        score = 0;

        if (typeof game_loop != "undefined") clearInterval(game_loop);
        game_loop = setInterval(function () {
            paint(snake, food)
        }, 100);
    }

    function paint(snake, food) {
        ctx.fillStyle = "white";
        ctx.fillRect(0, 0, w, h);
        ctx.strokeStyle = "black";
        ctx.strokeRect(0, 0, w, h);

        //Pop out the tail cell and place it infront of the head cell
        var nx = snake.snakeArray[0].x;
        var ny = snake.snakeArray[0].y;

        //Get the new head position
        if (d == "right") nx++;
        else if (d == "left") nx--;
        else if (d == "up") ny--;
        else if (d == "down") ny++;

        //Restart the game if the snake hits the wall or if the head of the snake bumps into its body
        if (nx == -1 || nx == w / cw || ny == -1 || ny == h / cw || checkCollision(nx, ny, snake.snakeArray)) {
            start();
            return;
        }

        //If the new head position matches with that of the food,
        //Create a new head instead of moving the tail
        if (nx == food.x && ny == food.y) {
            var tail = { x: nx, y: ny };
            score++;

            //Create new food
            makeFood();
        }
        else {
            //pops out the last cell
            var tail = snake.snakeArray.pop();
            tail.x = nx; tail.y = ny;
        }

        //puts back the tail as the first cell
        snake.snakeArray.unshift(tail);

        for (var i = 0; i < snake.snakeArray.length; i++) {
            var c = snake.snakeArray[i];
            paintCell(c.x, c.y);
        }

        paintCell(food.x, food.y);

        var score_text = "Score: " + score;
        ctx.fillText(score_text, 5, h - 5);
    }

    function makeFood() {
        food = new Food(w, h, cw);
    }

    //Paint cells
    function paintCell(x, y) {
        ctx.fillStyle = "blue";
        ctx.fillRect(x * cw, y * cw, cw, cw);
        ctx.strokeStyle = "white";
        ctx.strokeRect(x * cw, y * cw, cw, cw);
    }

    //Checks if the provided x/y coordinates exist in the array of cells
    function checkCollision(x, y, array) {
        for (var i = 0; i < array.length; i++) {
            if (array[i].x == x && array[i].y == y)
                return true;
        }
        return false;
    }

    //Add the keyboard controls
    $(document).keydown(function (e) {
        var key = e.which;
        if (key == "37" && d != "right") d = "left";
        else if (key == "38" && d != "down") d = "up";
        else if (key == "39" && d != "left") d = "right";
        else if (key == "40" && d != "up") d = "down";
    })

    return {
        newGame: start
    }
}());