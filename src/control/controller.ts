export class Controller {
    initialize(): void {
        this.setEvents();
    }

    private setEvents(): void {
        document.getElementById('btn_start')?.addEventListener('click', this.run);
    }

    private run(): void {
        const input = (document.getElementById('input_digits') as HTMLInputElement).value;
        const output = 'Lorem ipsum dolor sit amet consectetur, adipisicing elit. Vel, quaerat!'; // TODO: Replace with actual output from the conversion logic.
        (document.getElementById('textarea_output') as HTMLTextAreaElement).value = input + output;
    }
}