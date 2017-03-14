function test(input) {
let text = input.join(' ');
    let regex = /\d+/g;
    let ss = text.match(regex);
    console.log(ss.join(' '));

}