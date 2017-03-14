function test(input) {
    let result = [];
    let sum = 0;
    for (let row of input){
        let town = row.split('|');
        let townName = town[1].trim();
        let income = Number(town[2].trim());
        sum += income;
        result.push(townName);
    }

    console.log(result.join(', ') + '\n' + sum)
}