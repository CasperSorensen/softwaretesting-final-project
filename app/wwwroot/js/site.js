// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const form = document.getElementById('UserModel');
form.addEventListener("change", () => {
    document.getElementById('match-me').disabled = !form.checkValidity()
});