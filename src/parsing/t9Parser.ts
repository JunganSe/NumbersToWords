import { T9Map } from "@/parsing/t9Maps";

/** Parses T9 digits into all possible letter combinations. */
export class T9Parser {
    /** Returns all possible letter combinations for the given T9 input and mapping. */
    static getAllCombinations(input: string, t9Map: T9Map): string[] {
        let outputCombinations: string[] = [''];
        const inputDigits = [...input]
            .map(d => parseInt(d))
            .filter(d => !isNaN(d));

        for (const inputDigit of inputDigits) {
            const mappedLetters = this.getLettersForDigit(inputDigit, t9Map);
            outputCombinations = this.getNewCombinations(mappedLetters, outputCombinations);
        }
        return outputCombinations;
    }

    /** Returns the letters mapped to the given digit in the T9 map. */
    private static getLettersForDigit(digit: number, t9Map: T9Map): string[] {
        const key = `key${digit}`;
        return t9Map[key as keyof T9Map] || [];
    }

    /** Returns all possible combinations based on the existing combinations with the new letters appended. */
    private static getNewCombinations(letters: string[], existingCombinations: string[]): string[] {
        const newCombinations: string[] = [];
        for (const existingCombination of existingCombinations) {
            for (const letter of letters) {
                newCombinations.push(existingCombination + letter);
            }
        }
        return newCombinations;
    }
}