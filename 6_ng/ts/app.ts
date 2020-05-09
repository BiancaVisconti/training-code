import EventHandler from './event';

let main: any = document.querySelector("main");
let eh: EventHandler = new EventHandler();

main.addEventListener("click", eh.Click);
