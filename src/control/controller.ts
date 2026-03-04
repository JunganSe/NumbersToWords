import { htmlHandler } from "io/htmlHandler";

export class Controller {
    initialize(): void {
        this.setEvents();
    }

    private setEvents(): void {
        document.getElementById('btn_start')?.addEventListener('click', this.run);
    }

    private run(): void {
        const input = htmlHandler.getInputText();
        const output = 'Lorem ipsum dolor sit amet consectetur, adipisicing elit. Vel, quaerat!'; // TODO: Replace with actual output from the conversion logic.
        htmlHandler.setOutputText(input + output);
    }
}