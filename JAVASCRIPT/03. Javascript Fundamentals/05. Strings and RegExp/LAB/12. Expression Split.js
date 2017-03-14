function tesst([input]) {
   let pattern = /['\s.;\()\[\],\\.]+/g;

    let result = input.split(pattern);

    console.log(result.join('\n'));

}