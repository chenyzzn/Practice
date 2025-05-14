import cv2
import numpy as np

image = cv2.imread('image.jpg')
hsv_image = cv2.cvtColor(image, cv2.COLOR_BGR2HSV)

lower_bound = np.array([85, 150, 200])
upper_bound = np.array([95, 255, 255])
mask = cv2.inRange(hsv_image, lower_bound, upper_bound)

filtered_image = cv2.bitwise_and(image, image, mask=mask)
gray_image = cv2.cvtColor(filtered_image, cv2.COLOR_BGR2GRAY)

# 高斯模糊
blurred_image = cv2.GaussianBlur(gray_image, (7, 7), 0)
cv2.imshow('blurred_image', cv2.resize(blurred_image, (960, 720)))
cv2.waitKey(0)

# Canny邊緣檢測
edges = cv2.Canny(blurred_image, threshold1=300, threshold2=350)
cv2.imshow('edges', cv2.resize(edges, (960, 720)))
cv2.waitKey(0)

#膨脹操作
kernel = np.ones((5, 5), np.uint8)
dilated_edges = cv2.dilate(edges, kernel, iterations=1)
cv2.imshow('dilated_edges', cv2.resize(dilated_edges, (960, 720)))
cv2.waitKey(0)

#霍夫線變換
lines = cv2.HoughLinesP(dilated_edges, 1, np.pi / 180, threshold=100, minLineLength=50, maxLineGap=10)

for line in lines:
    x1, y1, x2, y2 = line[0]
    cv2.line(image, (x1, y1), (x2, y2), (0, 0, 255), 3)

cv2.imshow('Detected Lines', cv2.resize(image, (960, 720)))
cv2.waitKey(0)
cv2.destroyAllWindows()
