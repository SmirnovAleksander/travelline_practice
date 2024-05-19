"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var fs = require("fs");
var node_html_parser_1 = require("node-html-parser");
var HtmlParser = function (htmlFilePath) {
    var htmlFile = fs.readFileSync(htmlFilePath, "utf8");
    var resources = (0, node_html_parser_1.parse)(htmlFile)
        .querySelectorAll("[src], [href]")
        .map(function (element) {
        var src = element.getAttribute("src");
        var href = element.getAttribute("href");
        return [src, href].filter(function (url) { return url !== null; });
    })
        .reduce(function (acc, val) { return acc.concat(val); }, [])
        .filter(function (url) { return url !== undefined; });
    return resources;
};
var htmlFilePath = process.argv[2];
var resources = HtmlParser(htmlFilePath);
console.log(resources);
