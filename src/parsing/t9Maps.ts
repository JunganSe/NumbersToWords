export type T9Map = {
    key1: string[];
    key2: string[];
    key3: string[];
    key4: string[];
    key5: string[];
    key6: string[];
    key7: string[];
    key8: string[];
    key9: string[];
    key0: string[];
}

export class T9Maps {
    /** Standard T9 map. */
    static readonly t9: T9Map = {
        key1: [],
        key2: ['a', 'b', 'c'],
        key3: ['d', 'e', 'f'],
        key4: ['g', 'h', 'i'],
        key5: ['j', 'k', 'l'],
        key6: ['m', 'n', 'o'],
        key7: ['p', 'q', 'r', 's'],
        key8: ['t', 'u', 'v'],
        key9: ['w', 'x', 'y', 'z'],
        key0: [],
    };

    /** Extended T9 map where 1 is same as 2, and 0 is same as 9. */
    static readonly t9Extended: T9Map = {
        key1: ['a', 'b', 'c'],
        key2: ['a', 'b', 'c'],
        key3: ['d', 'e', 'f'],
        key4: ['g', 'h', 'i'],
        key5: ['j', 'k', 'l'],
        key6: ['m', 'n', 'o'],
        key7: ['p', 'q', 'r', 's'],
        key8: ['t', 'u', 'v'],
        key9: ['w', 'x', 'y', 'z'],
        key0: ['w', 'x', 'y', 'z'],
    };
}
