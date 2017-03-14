function gradsToRadians([input]) {

    let grads = Number(input);

    grads %= 400;
    grads += 400;
    grads %= 400;

    let degrees = grads * 0.9;

    console.log(degrees);
}