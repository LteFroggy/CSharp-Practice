# BMI 계산기

BMI(체질량지수)를 계산하고 비만도를 판정하는 프로그램을 작성하세요.

**요구사항**

1. `CalculateBmi(double height, double weight)` 함수 작성
   - 키(cm)와 몸무게(kg)를 받아 BMI를 계산하여 반환
   - BMI 공식: 몸무게(kg) / (키(m) × 키(m))
   - 키는 cm 단위이므로 m로 변환 필요
   - 반환 타입: `double`

2. `GetCategory(double bmi)` 함수 작성
   - BMI 값을 받아 비만도를 문자열로 반환
   - 판정 기준:
     - 18.5 미만: "저체중"
     - 23.0 미만: "정상"
     - 25.0 미만: "과체중"
     - 25.0 이상: "비만"

3. `PrintResult(string name, double height, double weight)` 함수 작성
   - 위 두 함수를 활용하여 결과를 출력

4. 다음 3명의 정보를 출력하세요:
   - 홍길동: 키 175cm, 몸무게 70kg
   - 김철수: 키 168cm, 몸무게 85kg
   - 이영희: 키 160cm, 몸무게 45kg

## 예상 실행 결과

```
=== BMI 계산기 ===

[홍길동]
키: 175cm, 몸무게: 70kg
BMI: 22.9, 판정: 정상

[김철수]
키: 168cm, 몸무게: 85kg
BMI: 30.1, 판정: 비만

[이영희]
키: 160cm, 몸무게: 45kg
BMI: 17.6, 판정: 저체중
```
