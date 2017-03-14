function test([string, delimiter]) {

    let ss = string.split(delimiter);
    for (let i = 0; i< ss.length; i++){
        console.log(ss[i]);
    }
}