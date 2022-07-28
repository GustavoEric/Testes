import express from 'express'
import http from 'http'
import criarJogo from './public/jogo.js'
import {Server} from 'socket.io'

const app = express()
const server = http.createServer(app)
const io = new Server(server,{
    cors:{
        origin:'*'
    }

})

app.get('/',(req,res)=>{
    res.sendFile(__dirname+'public/index.html')
})

app.use(express.static('public'))
const jogo = criarJogo()

jogo.inscrever((command) => {
    console.log('Emitting',command.type)
    io.emit(command.type,command)
})

io.on('connection', (socket) => {
    console.log(jogo.estado)
    const jogadorId = socket.id
    console.log('Jogador Connectado ',jogadorId)

    jogo.addJogador({jogadorId: jogadorId})

    io.emit('setup',jogo.estado)

    socket.on('disconnect', () => {
        jogo.removerJogador({jogadorId: jogadorId})
        console.log('Jogador Desconectado: ',jogadorId)
    })

    socket.on('move-jogador',(command)=>{
        command.jogadorId = jogadorId
        command.type = 'move-jogador'

        jogo.moveJogador(command)
    })
})


server.listen(3000, () =>{
    console.log('Servidor usando porta: 3000')
})