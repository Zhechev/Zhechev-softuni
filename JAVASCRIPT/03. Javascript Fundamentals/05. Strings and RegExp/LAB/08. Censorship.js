function test(input) {
    let text = input[0];
    let words = input.slice(1);

    for (let element of words){
        let repeater = '-'.repeat(element.length);
        while(text.indexOf(element) > -1){
            text = text.replace(element, repeater)
        }
    }
    console.log(text);
}