function figureofFourSquares([n]) {
    let input = Number(n);

    if (input == 2) {
            console.log('+'.repeat(3));

    }
    else {
        if (input % 2 == 0) {
            console.log('+' + '-'.repeat(input - 2) + '+' + '-'.repeat(input - 2) + '+');
            for (let row = 1; row < ((input - 3) / 2); row++) {
                console.log('|' + ' '.repeat(input - 2) + '|' + ' '.repeat(input - 2) + '|');
            }
            console.log('+' + '-'.repeat(input - 2) + '+' + '-'.repeat(input - 2) + '+');
            for (let row = 1; row < ((input - 3) / 2); row++) {
                console.log('|' + ' '.repeat(input - 2) + '|' + ' '.repeat(input - 2) + '|');
            }
            console.log('+' + '-'.repeat(input - 2) + '+' + '-'.repeat(input - 2) + '+');
        }
        else {
            console.log('+' + '-'.repeat(input - 2) + '+' + '-'.repeat(input - 2) + '+');
            for (let row = 0; row < ((input - 4) / 2); row++) {
                console.log('|' + ' '.repeat(input - 2) + '|' + ' '.repeat(input - 2) + '|');
            }
            console.log('+' + '-'.repeat(input - 2) + '+' + '-'.repeat(input - 2) + '+');
            for (let row = 0; row < ((input - 4) / 2); row++) {
                console.log('|' + ' '.repeat(input - 2) + '|' + ' '.repeat(input - 2) + '|');
            }
            console.log('+' + '-'.repeat(input - 2) + '+' + '-'.repeat(input - 2) + '+');
        }

    }
}