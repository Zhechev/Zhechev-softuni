function multiplicationTable([input]) {
    let flag = 0;
    let html = "<table border = '1'>";
        html += `<tr><th>x</th>`;
        for(let i =1; i<=input; i++){
            html += `<th>${i}</th>`;
        }
        html += `</tr>`;
    html += `\n`;

        for(let row = 1; row <=input;row++) {
            html += `<tr><th>${row}</th>`;
                for (let col = 1; col <= input; col++) {

                        html += `<td>${col * row}</td>`;



                }

                html += `</tr>`;
                html += `\n`;
            }


    html += ' </table>';
    return html;
}
