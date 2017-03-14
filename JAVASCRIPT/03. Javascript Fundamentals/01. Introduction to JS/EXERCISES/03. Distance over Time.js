function distanceOverTime([a, b, time]) {
    [a,b,time] = [a,b,time].map(Number);
    let playerA = a * 1000;
    let playerB = b * 1000;
    let timeInHours = time / 3600;
    let playerAFinal = playerA * timeInHours;
    let playerBFinal = playerB * timeInHours;
    console.log(Math.abs(playerAFinal - playerBFinal));
}