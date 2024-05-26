import { Command } from "commander";
import { HtmlParser } from "./HtmlParser";
import { OutJsonDifference } from "./JsonDiff";

const program = new Command();

program
  .command("html-resources")
  .description("this comand - Html Parser")
  .argument("<file>")
  .action((fileName: string) => {
    console.log(HtmlParser(fileName))
  });

program
  .command("json-diff")
  .description("this comand - json-diff")
  .argument('<file1>')
	.argument('<file2>')
  .action((file1: string, file2: string) => {
    console.log(JSON.stringify(OutJsonDifference(file1, file2), null, 2))
  });

program.parse();
