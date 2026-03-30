export function callOnEnterKey(event: KeyboardEvent, callback: () => void): void {
    if (event.key === 'Enter')
        callback();
}