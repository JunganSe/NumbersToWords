import { htmlHandler } from "@/io/htmlHandler";
import { inputValidator } from "@/validation/inputValidator";

export class Controller {
    initialize(): void {
        this.setEvents();
    }

    private setEvents(): void {
        document.getElementById('btn_start')?.addEventListener('click', this.run);
    }

    private run(): void {
        const input = htmlHandler.getInputText();
        if (!input)
            return;

        const isInputValid = validateInput(input);
        if (!isInputValid) {
            htmlHandler.setOutputText('Invalid input. Please enter only digits.');
            return;
        }

        const letterCombinations = getLetterCombinations(input);
        const matchingWords = findMatchingWords(letterCombinations);
        htmlHandler.setOutputText(matchingWords);
    }
}