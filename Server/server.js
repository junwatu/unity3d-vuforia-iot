const express = require('express')
const app = express()
const bodyParser = require('body-parser')
const notifier = require('node-notifier')

const jsonParser = bodyParser.json();

const port = 3003;

app.get('/', (req, res) => { res.send('REST Server') })

app.post('/api/lamp', jsonParser, (req, res) => {

    if (!req.body) return res.sendStatus(400)

    let status = req.body.status

    if (!req.body.status) {
        res.send('status empty')
    } else {
        // send data to control device (Arduiono, etc) 
        // Simple notification
        notifier.notify({
            title: 'Lamp State',
            message: status
        });
        //
        res.send('OK')
    }
})

app.listen(port, () => console.log(`REST server on ${port}`)) 
