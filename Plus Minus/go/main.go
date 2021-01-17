package main

import (
	"bufio"
	"fmt"
	"io"
	"os"
	"strconv"
	"strings"
)

// Complete the plusMinus function below.
func plusMinus(arr []int32) {
	var (
		positiveNumberCount = 0
		negativeNumberCount = 0
		zeroCount           = 0
	)

	for _, i := range arr {

		switch {
		case i < 0:
			negativeNumberCount++

		case i > 0:
			positiveNumberCount++

		case i == 0:
			zeroCount++
		}
	}

	fmt.Printf("%.6f\n", float64(positiveNumberCount)/float64(len(arr)))
	fmt.Printf("%.6f\n", float64(negativeNumberCount)/float64(len(arr)))
	fmt.Printf("%.6f\n", float64(zeroCount)/float64(len(arr)))
}

func main() {
	reader := bufio.NewReaderSize(os.Stdin, 1024*1024)

	nTemp, err := strconv.ParseInt(readLine(reader), 10, 64)
	checkError(err)
	n := int32(nTemp)

	arrTemp := strings.Split(readLine(reader), " ")

	var arr []int32

	for i := 0; i < int(n); i++ {
		arrItemTemp, err := strconv.ParseInt(arrTemp[i], 10, 64)
		checkError(err)
		arrItem := int32(arrItemTemp)
		arr = append(arr, arrItem)
	}

	plusMinus(arr)
}

func readLine(reader *bufio.Reader) string {
	str, _, err := reader.ReadLine()
	if err == io.EOF {
		return ""
	}

	return strings.TrimRight(string(str), "\r\n")
}

func checkError(err error) {
	if err != nil {
		panic(err)
	}
}
