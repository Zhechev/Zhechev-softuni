function test([input]) {
    input = input.toUpperCase();
    let result = [];
    let otherElements ='';
    let word = '';
let text = input.split(' ');

    for (let element of text){
        let word = element[0]
        for (let i = 1; i < element.length; i++){
                otherElements += element[i].replace(element[i], element[i].toLowerCase());
        }
        word += otherElements;
        otherElements = '';
        result.push(word);
    }

    console.log(result.join(' '));
}