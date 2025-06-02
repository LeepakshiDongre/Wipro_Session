function sendMessage() {
    const name = document.getElementById("name").value;
    alert("Thank you, " + name + "! Your message has been sent.");
    return false; // prevents the page from refreshing
}