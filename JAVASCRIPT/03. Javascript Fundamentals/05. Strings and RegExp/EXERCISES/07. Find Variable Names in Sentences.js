function test(input) {
    let result = [];
    let text = input.join(' ');
    let pattern = /\b_([a-z0-9]+)\b/ig;
    let match = pattern.exec(text);
    while (match) {
        result.push(match[1]);
        match = pattern.exec(text);
    }


    console.log(result.join(','));
}