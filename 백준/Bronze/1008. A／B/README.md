# [Bronze V] A/B - 1008 

[문제 링크](https://www.acmicpc.net/problem/1008) 

### 성능 요약

메모리: 5508 KB, 시간: 48 ms

### 분류

구현, 사칙연산, 수학

### 제출 일자

2025년 8월 18일 20:36:17

### 문제 설명

<p>두 정수 A와 B를 입력받은 다음, A/B를 출력하는 프로그램을 작성하시오.</p>

### 입력 

 <p>첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)</p>

### 출력 

 <p>첫째 줄에 A/B를 출력한다. 실제 정답과 출력값의 절대오차 또는 상대오차가 10<sup>-9</sup> 이하이면 정답이다.</p>

 String[] input = Console.ReadLine().Split(); => 입력받기
  int A  = int.Parse(input[0]);
  int B = int.Parsw(input[1]); 혹은
  double A = double.Parse(input[0]);
  double B = dpuble.Parse(input[1]); 로 써도된다.

  또는 위의 int 를 그대로 냅두고 출력문에서 캐스팅 방법으로 double로 써도 된다.
  Console.WriteLine((double) A / B);

