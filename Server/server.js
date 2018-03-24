const express = require('express')
const app = express()
const bodyParser = require('body-parser')

const jsonParser = bodyParser.json();

app.get('/', (req, res) => { res.send('REST Server') })

app.post('/api/lamp', jsonParser, (req, res) => {
    
    console.log(req.body);

    if (!req.body) return res.sendStatus(400)
    
    let status = req.body.status

    if (!req.body.status) {
        console.log(status)
        res.send('status empty')
    } else {
        console.log(status)
        res.send('OK')
    }
})

app.listen(3003, () => console.log('Started')) 
