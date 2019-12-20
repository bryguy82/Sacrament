// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function adjVal1(ddlHymns) {
    hymnNum = getHymnNumber(ddlHymns);
    document.getElementById("Hymn_1Num").value = hymnNum;
    document.getElementById("Num1").innerHTML = hymnNum;
}

function adjVal2(ddlHymns) {
    hymnNum = getHymnNumber(ddlHymns);
    document.getElementById("Hymn_2Num").value = hymnNum;
    document.getElementById("Num2").innerHTML = hymnNum;
}

function adjVal3(ddlHymns) {
    hymnNum = getHymnNumber(ddlHymns);
    document.getElementById("Hymn_3Num").value = hymnNum;
    document.getElementById("Num3").innerHTML = hymnNum;
}

function adjVal4(ddlHymns) {
    hymnNum = getHymnNumber(ddlHymns);
    document.getElementById("Hymn_4Num").value = hymnNum;
    document.getElementById("Num4").innerHTML = hymnNum;
}

function getHymnNumber(ddlHymns) {
    hymn = 0
    switch (ddlHymns) {
        case "High on the Mountain Top":
            hymn = 5;
            break;
        case "I Saw a Mighty Angel Fly":
            hymn = 15;
            break;
        case "We Thank Thee, O God, for a Prophet":
            hymn = 19;
            break;
        case "Christ the Lord Is Risen Today":
            hymn = 200;
            break;
        case "Nearer, My God, to Thee":
            hymn = 100;
            break;
        case "The Morning Breaks":
            hymn = 1;
            break;
        case "The Iron Rod":
            hymn = 274;
            break;
        case "As I Search the Holy Scriptures":
            hymn = 277;
            break;
        case "How Firm a Foundation":
            hymn = 85;
            break;
        case "Rejoice, the Lord Is King!":
            hymn = 66;
            break;
        case "Joseph Smith's First Prayer":
            hymn = 26;
            break;
        case "Lord, I Would Follow Thee":
            hymn = 220;
            break;
        case "Love at Home":
            hymn = 294;
            break;
        default:
            hymn = 0;
            break;
    }
    return hymn;
}
