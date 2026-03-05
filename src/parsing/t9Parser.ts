import { T9Map, T9Maps } from "@/parsing/t9Maps";

export class T9Parser {
    /** Parses T9 digits into all possible letter combinations. */
    static parse(digits: string): string[] {
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