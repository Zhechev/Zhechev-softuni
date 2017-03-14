function test(input) {

    let products = input.filter((x,i) => i % 2 == 0);
    let sum = input.filter((x,i) => i%2 == 1).map(Number).reduce((a,b) => a+b);
    console.log(`You purchased ${products.join(', ')} for a total sum of ${sum}`);

}