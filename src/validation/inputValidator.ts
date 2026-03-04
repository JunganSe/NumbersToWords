export class inputValidator {
    static isDigitsOnly(input: string): boolean {
        const regex = /^\d+$/;
        return regex.test(input);
    }
}