import EventHandler from './event';
let main = document.querySelector("main");
let eh = new EventHandler();
main.addEventListener("click", eh.Click);
