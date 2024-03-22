document.addEventListener("DOMContentLoaded", function() {

    var showInfoBtn = document.getElementById("show-info-btn");
    var infoBox = document.getElementById("info-box");


    showInfoBtn.addEventListener("click", function() {

        infoBox.style.display = "block";
    });
});
