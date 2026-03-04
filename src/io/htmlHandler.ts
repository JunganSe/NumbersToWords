export class htmlHandler {
    static getInputText(): string {
        const element = document.querySelector('#input_digits') as HTMLInputElement | null;
        return element?.value ?? '';
    }

    static setOutputText(output: string): void {
        const element = document.querySelector('#textarea_output') as HTMLTextAreaElement | null;
        if (element)
            element.value = output;
    }
}