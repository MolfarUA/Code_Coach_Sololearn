class MusicPlayer {
    private var songs: Array<String> = arrayOf()
    //your code goes here
fun add(track: String): Array<String>{
     songs = songs + track
    return songs
}

fun show(){
  
  for(track in songs.indices){
      println(songs[track])
  }
  
}

fun play(){
    println("Playing "+songs[0])
  
}

}
fun main(args: Array<String>) {
    val m = MusicPlayer()
    
    while(true) {
        var input = readLine()!!
        if(input == "stop") {
            break
        }
        m.add(input)
    }
    m.show()
    m.play()
}
