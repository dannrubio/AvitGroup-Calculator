const readline = require('readline');

const validAnswers = ['YES', 'NO'];
const iface = readline.createInterface(process.stdin, process.stdout);

iface.question('Do you Bleed? ', (answer) => {
  let ucAnswer = answer.trim().toUpperCase();
  if (!validAnswers.includes(ucAnswer)) {
    console.log('You can only answer YES or NO. ');
  } else {
    console.log(ucAnswer === 'YES' ? 'What\'s your blood type then? ' : 'What? How can you not bleed? ');
  }
});

iface.on('SIGINT', () => {
  iface.close();
  process.emit('SIGINT');
});

process.on('SIGINT', () => {
  process.stdin.destroy();
  process.exit();
});
