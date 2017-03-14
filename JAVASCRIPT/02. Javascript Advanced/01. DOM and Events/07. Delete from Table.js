function deleteByEmail() {
    let col2 = document.querySelectorAll("#customers tr td:nth-child(2)");
    let email = document.getElementsByName("email")[0].value;
    console.log(email);
    for (let td of col2) {
        if (td.textContent == email) {
            td.parentNode.parentNode.removeChild(td.parentNode);
            document.getElementById("result").textContent = "Deleted";

        }
        else {
            document.getElementById("result").textContent = "Not found.";
        }
    }
}