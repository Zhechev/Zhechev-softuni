function test(input) {
    let letter = 0;
    let result = [];
    for (let email of input) {
        let [name, domain] = email.split('@');
        let username = name + '.';
        let leftUsername = domain.split('.');
        for (let el of leftUsername) {
            letter = el[0];
            username += letter;
        }
        result.push(username);

    }
    console.log(result.join(', '))
}