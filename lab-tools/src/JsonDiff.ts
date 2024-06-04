import * as fs from 'fs';

type JsonData = Record<string, unknown>;

type JsonResult = Record<string, {
    type: 'New'|'Delete'|'Changed'|'Unchanged',
    oldValue?: unknown,
    newValue?: unknown,
    children?: JsonResult
}>;

export const OutJsonDifference = (oldJsonFile: string, newJsonFile: string) : JsonResult => {
    const oldJsonData: JsonData = JSON.parse(fs.readFileSync(oldJsonFile, 'utf8'));
    const newJsonData: JsonData = JSON.parse(fs.readFileSync(newJsonFile, 'utf8'));

    return JsonDifference(oldJsonData, newJsonData);
};

const isJsonObject = (value: unknown): value is Record<string, unknown> =>
    typeof value === 'object' && value !== null;

// const areBothJsonObjects = (value1: unknown, value2: unknown): boolean =>
//     isJsonObject(value1) && isJsonObject(value2);

const JsonDifference = (oldJson: Record<string, unknown>, newJson: Record<string, unknown>): JsonResult => {
    const keys: string[] = [...Object.keys(oldJson), ...Object.keys(newJson)] 

    return keys.reduce<JsonResult>((JsonResult: JsonResult, key: string) => {
        const oldValue = oldJson[key];
        const newValue = newJson[key];

        if(typeof oldValue === 'undefined')
            return {
                ...JsonResult,
                [key]: {
                    type: 'New',
                    newValue
                }
            }

        if(typeof newValue === 'undefined')
            return {
                ...JsonResult,
                [key]: {
                    type: 'Delete',
                    oldValue
                }
            }  
        
        if (isJsonObject(oldValue) && isJsonObject(newValue)) {
            const childrenJson = JsonDifference(oldValue, newValue);
            return {
                ...JsonResult,
                [key]: {
                    type: JSON.stringify(oldValue) === JSON.stringify(newValue) ? 'Unchanged' : 'Changed',
                    children: childrenJson
                }
            }
        }

        return {
            ...JsonResult,
            [key]: {
                type: oldValue === newValue ? 'Unchanged' : 'Changed',
                oldValue,
                newValue
            }
        }

    },{});
}