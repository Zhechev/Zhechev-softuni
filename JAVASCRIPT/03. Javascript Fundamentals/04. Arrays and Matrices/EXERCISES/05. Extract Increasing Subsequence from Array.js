function extract(input) {
    input = input.map(Number)
    let result = [];
    let prevElement = -Infinity
    for (let element of input)
        if (element >= prevElement){
            prevElement = element;
            result.push(prevElement);}

    console.log(result.join('\n'))
}