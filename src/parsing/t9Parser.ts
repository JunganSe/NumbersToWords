import { T9Map, T9Maps } from "@/parsing/t9Maps";

/** Parses T9 digits into all possible letter combinations. */
export class T9Parser {
    /** Returns all possible letter combinations for the given T9 input and mapping. */
    static getAllCombinations_v3(input: string, t9Map: T9Map): string[] {
        const inputDigits = [...input]
            .map(d => parseInt(d))
            .filter(d => !isNaN(d));

        let outputCombinations: string[] = [''];

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


    /** Returns all possible letter combinations for the given T9 input and mapping. */
    static getAllCombinations_v2(input: string, t9Map: T9Map): string[] {
        const inputDigits = [...input]
            .map(d => parseInt(d))
            .filter(d => !isNaN(d));

        let outputCombinations: string[] = [''];

        for (const inputDigit of inputDigits) {
            const key = `key${inputDigit}`;
            const mappedLetters = t9Map[key as keyof T9Map];
            const newCombinations: string[] = [];

            for (const outputCombination of outputCombinations) {
                for (const mappedLetter of mappedLetters) {
                    newCombinations.push(outputCombination + mappedLetter);
                }
            }
            outputCombinations = newCombinations;
        }
        return outputCombinations;
    }



    /** Returns all possible letter combinations for the given T9 input and mapping. */
    static getAllCombinations_v1(digits: string): string[] { // Made by copilot.
        console.log('-- Starting parse --');
        const map = T9Maps.t9;

        const combinations: string[] = [''];
        for (const digit of digits) {
            console.log('Parsing digit:', digit);

            const key = `key${digit}`;
            const letters = map[key as keyof T9Map];
            const newCombinations: string[] = [];
            for (const combination of combinations) {
                for (const letter of letters) {
                    newCombinations.push(combination + letter);
                }
            }
            combinations.length = 0;
            combinations.push(...newCombinations);
        }

        console.log('-- Parse complete. --');
        return combinations;
    }
}