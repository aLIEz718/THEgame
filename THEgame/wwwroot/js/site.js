// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//* Цикл через все кнопки выпадающего списка для переключения между скрытием и отображением его выпадающего содержимого - это позволяет пользователю иметь несколько выпадающих списков без каких-либо конфликтов */
var dropdown = document.getElementsByClassName("dropdown-btn");
var i;

for (i = 0; i < dropdown.length; i++) {
    dropdown[i].addEventListener("click", function () {
        this.classList.toggle("active");
        var dropdownContent = this.nextElementSibling;
        if (dropdownContent.style.display === "block") {
            dropdownContent.style.display = "none";
        } else {
            dropdownContent.style.display = "block";
        }
    });
}
function textconsole(param) {
    let a = document.getElementById('flex2');
    var p = document.createElement("div");
    p.className = 'chatmessage';
    p.textContent = "System: " + param;
    a.append(p)
}
function initializeClock(id) {
    var clock = document.getElementById(id);
    let but = [];
    textconsole("Вы можете перейти в следующую локацию через " + inta + " секунд");
    for (let i = 1; i <= id; i++) {
        but.push(document.getElementById("location" + i));
    }

    function updateClock() {
        clock.value = inta;
        inta = inta - 1;

        if (inta < 0) {
            clearInterval(timeinterval);
            for (let i = 0; i < id; i++) {
                but[i].removeAttribute("disabled");
            }
        }
    }

    updateClock();
    var timeinterval = setInterval(updateClock, 1000);
}
