function test(input) {
    let text = input[0];
    let result = [];
    let rightIndex = 0;
    while (true){
        let leftIndex = text.indexOf('(', rightIndex);
        if (leftIndex == -1){
            break;
        }
        rightIndex = text.indexOf(')', leftIndex);
        if (rightIndex == -1){
            break;
        }
        let element = text.substring(leftIndex+1, rightIndex);
        result.push(element);

    }

    console.log(result.join(', '));
}