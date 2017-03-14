function addItem() {
    let items = document.getElementById('items');
    let text = document.getElementById('newText').value;
    let li = document.createElement('li');
    li.textContent = text;

    let span = document.createElement('span');
    span.innerHTML = "<a href ='#'>[Delete]</a> ";
    span.addEventListener("click", function () {
        let li = span.parentNode;
        li.parentNode.removeChild(li);
    });
    li.appendChild(span);
    items.appendChild(li);

}