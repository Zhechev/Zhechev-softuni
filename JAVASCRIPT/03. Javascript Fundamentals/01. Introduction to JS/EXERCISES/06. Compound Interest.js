function compountInterest([a,b,c,d]) {

    [a,b,c,d] = [a,b,c,d].map(Number);

    let sum = a;
    let interesetRate = b / 100;
    let frequency = 12 / c;
    let overallLength = d;

    let result = sum * Math.pow(1 + interesetRate/frequency, frequency * overallLength);

    console.log(result.toFixed(2));
}