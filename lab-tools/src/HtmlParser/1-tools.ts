import * as fs from "fs";
import { parse, HTMLElement } from "node-html-parser";

const HtmlParser = (htmlFilePath: string): string[] => {
  const htmlFile: string = fs.readFileSync(htmlFilePath, "utf8");
  const resources: string[] = parse(htmlFile)
    .querySelectorAll("[src], [href]")
    .map((element: HTMLElement) => {
      const src = element.getAttribute("src");
      const href = element.getAttribute("href");
      return [src, href].filter((url) => url !== null) as string[];
    })
    .reduce((acc, val) => acc.concat(val), [])
    .filter((url) => url !== undefined);

  return resources;
}

const htmlFilePath: string = process.argv[2];
const resources: string[] = HtmlParser(htmlFilePath);
console.log(resources);
