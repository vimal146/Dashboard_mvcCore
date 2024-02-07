/*!
* Start Bootstrap - Landing Page v6.0.6 (https://startbootstrap.com/theme/landing-page)
* Copyright 2013-2023 Start Bootstrap
* Licensed under MIT (https://github.com/StartBootstrap/startbootstrap-landing-page/blob/master/LICENSE)
*/
// This file is intentionally blank
// Use this file to add JavaScript to your project



const form = document.querySelector("form"),
        nextBtn = form.querySelector(".nextBtn"),
        backBtn = form.querySelector(".backBtn"),
        allInput = form.querySelectorAll(".first input");

nextBtn.addEventListener("click", ()=> {
    allInput.forEach(input => {
        if (input.value != "") {
            form.classList.add('secActive');
        }else{
            form.classList.remove('secActive');
            /*alert("input is empty")*/
        }
    })
})

backBtn.addEventListener("click", ()=> form.classList.remove('secActive'));