function tesst(input) {

    let text = input[0];
    let pattern = /\w+/g;
    let words = text.match(pattern)

console.log(words.join('|'))


}