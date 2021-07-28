input = gets.chomp

if input.include?("AM") 
    if input[1] == ":"
        time = "0" + input[0] + ":" + input[2..3]
    else
        time = input[0..1] + ":"+ input[3..4]
    end
else
    if input[1] == ":"
        time = (input[0].to_i + 12).to_s + ":" + input[2..3]
    else
        time = (input[0..1].to_i + 12).to_s + ":"+ input[3..4]
    end
end

puts time
