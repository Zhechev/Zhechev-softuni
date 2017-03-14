function stringOfNumbers([a, b]) {
    [a,b] = [a,b].map(Number);
    console.log(Math.ceil(a / b))

    }