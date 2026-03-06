import { htmlHandler } from "@/io/htmlHandler";
import { T9Maps } from "@/parsing/t9Maps";
import { T9Parser } from "@/parsing/t9Parser";
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

        const isInputValid = inputValidator.isDigitsOnly(input);
        if (!isInputValid) {
            htmlHandler.setOutputText('Invalid input. Please enter only digits.');
            return;
        }

        const letterCombinations = T9Parser.getAllCombinations(input, T9Maps.t9);
        const matchingWords = letterCombinations.join(' '); // TEMP: Placeholder for actual word matching logic.
        // const matchingWords = findMatchingWords(letterCombinations);
        htmlHandler.setOutputText(matchingWords);
    }
}