# 문자열 유틸리티

다양한 문자열 처리 기능을 함수로 구현하세요.

**구현해야 할 함수:**

1. `Reverse(string text)` - 문자열을 뒤집어서 반환
2. `CountWords(string text)` - 공백으로 구분된 단어의 개수 반환
3. `IsPalindrome(string text)` - 회문(앞뒤로 읽어도 같은 문자열) 여부 확인
4. `Capitalize(string text)` - 각 단어의 첫 글자를 대문자로 변환
5. `RemoveDuplicateSpaces(string text)` - 연속된 공백을 하나의 공백으로 변환

**요구사항:**

- 모든 함수는 로컬 함수로 구현
- `IsPalindrome`은 대소문자를 구분하지 않고, 공백은 무시함
- `Capitalize`는 영문 문자열 기준으로 구현
- 적절한 입력 유효성 검사 포함 (null 또는 빈 문자열 처리)

## 예상 실행 결과

```
=== 문자열 유틸리티 테스트 ===

[Reverse 테스트]
원본: Hello World
결과: dlroW olleH

[CountWords 테스트]
문장: The quick brown fox jumps over the lazy dog
단어 개수: 9

[IsPalindrome 테스트]
"level" -> True
"hello" -> False
"A man a plan a canal Panama" -> True

[Capitalize 테스트]
원본: hello world example
결과: Hello World Example

[RemoveDuplicateSpaces 테스트]
원본: "Hello    World   Example"
결과: "Hello World Example"
```
